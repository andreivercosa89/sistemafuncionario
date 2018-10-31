using System;
namespace sistemafuncionario{
    public class Funcionario
    {
        public string Nome{
            set;get;
        }

        public double Salario{
            get;set;
                
        }

        public double novoSalario(){
            if(Salario <= 1000){
                return Salario * 1.3;
            }else if(Salario <=1500){
                return Salario * 1.2;
            }
            else{
                return Salario * 1.1;
            }
        }
    }
}
