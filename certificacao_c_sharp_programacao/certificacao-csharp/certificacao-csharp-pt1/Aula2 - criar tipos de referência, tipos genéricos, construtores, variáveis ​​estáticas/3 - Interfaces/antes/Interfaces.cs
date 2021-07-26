using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Interfaces : IAulaItem
    {
        public void Executar()
        {
            IEletrodimestico eletro1 = new Televisao();
            eletro1.Ligar();

            eletro1 = new Abajur();
        }
    }
    interface IIluminacao
    {
        double PotenciaDaLampada { get; set; }
    }


    interface IEletrodimestico
    {
        void Ligar();
        void Desligar();
    }

    class Televisao : IEletrodimestico
    {
        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Abajur : IEletrodimestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Lanterna : IEletrodimestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Radio : IEletrodimestico
    {
        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }
}
