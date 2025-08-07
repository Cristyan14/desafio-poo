# 📱 Desafio POO - DIO .NET - Sistema de Celulares

Este projeto faz parte do desafio proposto pela **Digital Innovation One (DIO)** no módulo de **Programação Orientada a Objetos (POO)** da trilha .NET.  
O objetivo é aplicar os conceitos de herança, abstração e polimorfismo utilizando classes para representar celulares.

---

## 📋 Descrição

O sistema simula a estrutura de celulares das marcas **Nokia** e **iPhone**, com base em uma classe abstrata chamada `Smartphone`, que define um modelo base para as demais classes filhas.

---

## 📚 Conceitos aplicados

- Abstração
- Herança
- Polimorfismo
- Sobrescrita de métodos (`override`)
- Encapsulamento
- Projeto de console com C#

---

## 🧱 Estrutura das Classes

### 📱 Smartphone (abstrata)

```csharp
public abstract class Smartphone
{
    public string Numero { get; set; }
    public string Modelo { get; set; }
    public string IMEI { get; set; }
    public int Memoria { get; set; }

    public abstract void InstalarAplicativo(string nomeApp);

    public void Ligar();
    public void ReceberLigacao();
}
📲 iPhone
Classe filha da Smartphone, sobrescreve o método InstalarAplicativo.

📲 Nokia
Classe filha da Smartphone, também sobrescreve InstalarAplicativo.

▶️ Como executar
Certifique-se de ter o .NET SDK instalado.

Clone este repositório:

bash
Copiar
Editar
git clone https://github.com/seu-usuario/seu-repositorio.git
Navegue até a pasta do projeto:

bash
Copiar
Editar
cd DesafioPOO
Execute o projeto:

bash
Copiar
Editar
dotnet run
💡 Exemplos de uso
No Program.cs você pode testar criando instâncias:

csharp
Copiar
Editar
Smartphone nokia = new Nokia("123456", "Nokia Tijolão", "111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Smartphone iphone = new Iphone("987654", "iPhone 15", "222222222", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
🛠 Tecnologias utilizadas
C#

.NET 6 ou superior

Console Application

