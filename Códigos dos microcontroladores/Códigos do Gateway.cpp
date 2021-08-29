#include <LoRa.h>
#include <SPI.h>
#include <SSD1306.h>
#include <WiFi.h>
#include <TinyGPS++.h>
#include <PubSubClient.h> //Biblioteca do Protocolo MQTT

#define BAND 915E6 //Frequência do radio - exemplo : 433E6, 868E6, 915E6

//Configurações do display
void setupDisplay(){
pinMode(16, OUTPUT);
digitalWrite(16, LOW);
digitalWrite(16, HIGH);
display.init();
display.flipScreenVertically();
display.setFont(ArialMT_Plain_16);
display.setTextAlignment(TEXT_ALIGN_LEFT);
}
//Configurações iniciais do LoRa
void setupLoRa(){ 
//Inicializa a comunicação
SPI.begin(SCK, MISO, MOSI, SS);
LoRa.setPins(SS, RST, DI00);

//Inicializa o LoRa
if (!LoRa.begin(BAND, true)){
//Se não conseguiu inicializar, mostra uma mensagem no display
display.clear();
display.drawString(0, 0, "Erro ao inicializar o LoRa!");
display.display();
while (1);
}
//Ativa o crc
LoRa.enableCrc();
//Ativa o recebimento de pacotes
LoRa.receive();
}

//Constante que o gateway recebe do endpoint
const String SETDATA = "setdata=";

//Estrutura com os dados do sensor
typedef struct {
float lat;
float lng;
float vel;
unsigned long dt, hr;
}Data;

//Variável para controlar o display
SSD1306 display(0x3c, SDA, SCL);

//Onde ficam os dados que chegam do outro dispositivo LoRa 
Data data;

void receive(){
//Tentamos ler o pacote
int packetSize = LoRa.parsePacket();
  
//Verificamos se o pacote tem o tamanho mínimo de caracteres que esperamos
if (packetSize > SETDATA.length()){
String received = "";
//Armazena os dados do pacote em uma string
for(int i=0; i<SETDATA.length(); i++){
received += (char) LoRa.read();
}

//Se o cabeçalho é o que esperamos
if(received.equals(SETDATA)){
//Fazemos a leitura dos dados
LoRa.readBytes((uint8_t*)&data, sizeof(data));
//Mostramos os dados no display
showData();
Serial.print("Publish message: ");
}
}
}

#define WIFISSID "WiFiConecta" //SSID do WiFi
#define PASSWORD "23456789" //Password do WiFi
#define TOKEN "BBFF-iFC4FPVRAfuKJi4CSZSbWSH55aWPvs" //TOKEN do Ubidots 
#define VARIABLE_LABEL_LATITUDE "lat" //Referente a variável criada no ubidots
#define VARIABLE_LABEL_LONGITUDE "lng" //Referente a variável criada no ubidots
#define VARIABLE_LABEL_VELOCIDADE "vel" //Referente a variável criada no ubidots
#define VARIABLE_LABEL_DATA "dt" //Referente a variável criada no ubidots
#define VARIABLE_LABEL_HORA "hr" //Referente a variável criada no ubidots
#define DEVICE_ID "612454e38addc1000d08f5ed" //ID do dispositivo
#define SERVER "things.ubidots.com" //Servidor do Ubidots (broker)

//Porta padrão
#define PORT 1883 //Sempre será essa

//Tópico aonde serão feitos os publish
#define TOPIC "/v1.6/devices/esp32-wifi-lora"

//Objeto WiFiClient usado para a conexão wifi
WiFiClient ubidots;

//Objeto PubSubClient usado para publish–subscribe
PubSubClient client(ubidots);

//Conexão
bool mqttInit()
{
//Inicia WiFi com o SSID e a senha
WiFi.begin(WIFISSID, PASSWORD);
 
//Loop até que o WiFi esteja conectado
while (WiFi.status() != WL_CONNECTED)
{
delay(1000);
Serial.println("Establishing connection to WiFi..");
}
 
//Exibe no monitor serial
Serial.println("Connected to network");

//Seta servidor com o broker e a porta
client.setServer(SERVER, PORT);
  
//Conecta no ubidots com o Device id e o token, o password é informado como vazio
while(!client.connect(DEVICE_ID, TOKEN, ""))
{
Serial.println("MQTT - Connect error");
return false;
}

Serial.println("MQTT - Connect ok");
return true;
}
//Reconexão
void reconnect() 
{  
//Loop até que o MQTT esteja conectado
while (!client.connected()) 
{
//sinaliza desconexão do mqtt no display
showDisplay(0,"Disconnected", true); 
showDisplay(1, "Trying to reconnect mqtt...", false);
 Serial.println("Attempting MQTT connection...");
    
//Tenta conectar
if (client.connect(DEVICE_ID, TOKEN,"")) 
Serial.println("connected");
else 
{
Serial.print("failed, rc=");
Serial.print(client.state());
Serial.println(" try again in 2 seconds");
//Aguarda 2 segundos antes de retomar
delay(2000);
}
}
//Sinaliza reconexão do mqtt no display
showDisplay(4,"Reconnected", false); 
}

//Envia valores por mqtt
bool sendValues(float data.lat, float data.lng, float data.vel, unsigned long data.dt, unsigned long data.hr)
{
char json[250];
 
//Atribui para a cadeia de caracteres "json" os valores referentes a lat e os envia para a variável do ubidots correspondente
sprintf(json,  "{\"%s\":{\"value\":%02.02f, \"context\":{\"lat\":%02.02f, \"lng\":%02.02f, \"vel\":%02.02f, \"dt\":%02.02f, \"hr\":%02.02f}}}", VARIABLE_LABEL_LATITUDE, data.lat, data.lat, data.lng, data.vel, data.dt, data.hr);  

if(!client.publish(TOPIC, json))                                 
return false;

//Atribui para a cadeia de caracteres "json" os valores referentes a lng e os envia para a variável do ubidots correspondente
sprintf(json,  "{\"%s\":{\"value\":%02.02f, \"context\":{\"lat\":%02.02f, \"lng\":%02.02f, \"vel\":%02.02f, \"dt\":%02.02f, \"hr\":%02.02f}}}", VARIABLE_LABEL_LONGITUDE, data.lng, data.lat, data.lng, data.vel, data.dt, data.hr); 
      
if(!client.publish(TOPIC, json))
return false;

//Atribui para a cadeia de caracteres "json" os valores referentes a vel e os envia para a variável do ubidots correspondente
sprintf(json,  "{\"%s\":{\"value\":%02.02f, \"context\":{\"lat\":%02.02f, \"lng\":%02.02f, \"vel\":%02.02f, \"dt\":%02.02f, \"hr\":%02.02f}}}", VARIABLE_LABEL_VELOCIDADE, data.vel, data.lat, data.lng, data.vel, data.dt, data.hr); 
      
if(!client.publish(TOPIC, json))
return false;
    
//Atribui para a cadeia de caracteres "json" os valores referentes a dt e os envia para a variável do ubidots correspondente
sprintf(json,  "{\"%s\":{\"value\":%02.02f, \"context\":{\"lat\":%02.02f, \"lng\":%02.02f, \"vel\":%02.02f, \"dt\":%02.02f, \"hr\":%02.02f}}}", VARIABLE_LABEL_DATA, data.dt, data.lat, data.lng, data.vel, data.dt, data.hr); 
      
if(!client.publish(TOPIC, json))
return false;
     
//Atribui para a cadeia de caracteres "json" os valores referentes a hr e os envia para a variável do ubidots correspondente
sprintf(json,  "{\"%s\":{\"value\":%02.02f, \"context\":{\"lat\":%02.02f, \"lng\":%02.02f, \"vel\":%02.02f, \"dt\":%02.02f, \"hr\":%02.02f}}}", VARIABLE_LABEL_HORA, data.hr, data.lat, data.lng, data.vel, data.dt, data.hr); 
      
if(!client.publish(TOPIC, json))
return false;
    
//Se tudo der certo retorna true
return true;
}