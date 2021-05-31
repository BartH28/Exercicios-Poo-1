using System;


namespace Exercicio_3.Classes
{
    public class maquinaDeCasa
    {
        public int acucarDisponivel = 50;

        public virtual string FazerCafe(int acucar){
            if (acucar == 0)
            {
                acucarDisponivel = acucarDisponivel - 10;
            }
            else
            {
                acucarDisponivel = acucarDisponivel - acucar;
            }
            return "Cafe quentinho com açucar saindo";
        }

        public virtual string FazerCafe(){

            return "Cafe quentinho saindo";
        }

    }
}