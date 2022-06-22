
// Exercicío
//Desenvolver uma classe Carro que possua marca, modelo, potencia do moto e 
//se possui sistema de freios abs. Depois de criados estes dados não podem ser alterados.
//Deve possuir dois métodos de simulação de velocidade: "Acelerar" e "Frear"
//Se o carro possuir mais de 100 cavalos, cada acelerada sobe a velocidade do veículo em 30km/h,
//enquanto que se tiver menos de 100 cavalos sobe para 15 km/h.
//Se tiver sistema abs e frear o veículo reduz 20km/h a velocidade, senão apenas 10km/h

Carro unoComEscada = new Carro("Fiat", "Uno com Escada", 0, true);
Carro Uninho = new Carro("Fiat", "Uno", 70, false);

unoComEscada.Acelerar();
unoComEscada.Acelerar();
unoComEscada.Acelerar();

Uninho.Acelerar();
Uninho.Acelerar();
Uninho.Acelerar();

unoComEscada.Frear();
Uninho.Frear();



Console.WriteLine("Velocidade do Uno com Escada: "+unoComEscada.Velocidade);
Console.WriteLine("Velocidade do Uno norma: " + Uninho.Velocidade);



class Carro
{
    public string Marca { get; private set; }
    public string Modelo { get; private set; }
    public double Potencia { get; private set; }
    public bool TemAbsFreio { get; private set; }
    
    public Carro(string marca, string modelo, int potencia, bool abs)
    {
        int pos = 0;
        for (pos = 0; pos <= 3; pos++)
        {
            if (marca == "")
            {
                throw new Exception("Valor não pode ser nulo");
            }
            if (modelo == "")
            {
                throw new Exception("Valor não pode ser nulo");
            }
            if (potencia == 0)
            {
                throw new Exception("Valor não pode ser nulo");
            }
           
        }
        this.Marca = marca;
        this.Modelo = modelo;
        this.Potencia = potencia;
        this.TemAbsFreio = abs;
 
        
    }

    public double Velocidade { get; private set; }
    public void Acelerar()
    {
            if (this.Potencia > 100)
            {
                this.Velocidade += 30;
            }
            else
            { 
                this.Velocidade += 15; 
            }
           
    

}

    public void Frear()
    {

        if(this.TemAbsFreio)
        {   
            if(this.Velocidade - 20 < 0)
            {
                this.Velocidade = 0;
            }
            this.Velocidade -= 20;
        }
        else
        {   
            if (this.Velocidade - 10 < 0)
            {
                this.Velocidade = 0;
            }
            this.Velocidade -= 10;
        }
        
    }
    



    

}

