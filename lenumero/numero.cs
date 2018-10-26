using System;
namespace lenumero
{
    public class numero
    {
        private int meunumero;

        public int pegaValorDefinido(){
            return meunumero;
        }

        public void defineNumero(int numeroDaTela)
        {
            meunumero = numeroDaTela;
        }

        public int sucessorDoNumero()
        {
            return (meunumero + 1);
        }
        public int antecessorDoNumero()
        {
            return (meunumero - 1);
        }
        public numero()
        {

        }
    }
}
