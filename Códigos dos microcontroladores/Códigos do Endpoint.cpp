#include <LoRa.h>
#include <SPI.h>
#include <SSD1306.h>
#include <TinyGPS++.h>

#define GPS_RX 22 // definição pinagem gps
#define GPS_TX 23 // definição pinagem gps

TinyGPSPlus gps;

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

//Constante que o endpoint retorna junto com os dados para o gateway
const String SETDATA = "setdata=";

// Definição variáveis
TinyGPSPlus gps;
float lat, lng, vel;
unsigned long dt, hr;

//Intervalo entre os envios
#define INTERVAL 50000

//Tempo do último envio
long lastSendTime = 0;

//Função onde se faz a leitura dos dados
Data readData()
{
Data data;
data.lat = gps.location.readlat();
data.lng = gps.location.readlng();
data.vel = gps.location.readvel();
data.dt = gps.location.readdt();
data.hr = gps.location.readhr();
return data;
}


//Cria o pacote para envio
void envio loop(){ 
if (millis() - lastSendTime > interval) {
LoRa.beginPacket();
LoRa.print(SETDATA);
LoRa.write((uint8_t*)&data, sizeof(data));
//Finaliza e envia o pacote
LoRa.endPacket();
showSentData(data);
lastSendTime = millis();// Timestamp da ultima mensagem
}
}

//Mostrando no Display os dados enviados 
void showSentData(Data data)
{

display.clear();
display.drawString(0, 0, "Enviou:");
display.drawString(0, 16, String(data.lat));
display.drawString(0, 32, String(data.lng));
display.drawString(0, 48, String(data.vel);
display.drawString(0, 64, String(data.dt);
display.drawString(0, 80, String(data.hr);
display.display();
}