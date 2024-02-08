using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ExamenU1JDPC.VistaModelo
{
    public class VMexamen : BaseViewModel
    {
        
        #region VARIABLES
        string _Texto;
        string _Resultado;
        double _Peso;
        double _Altura;
        bool _Imc;
        bool _FCN;
     
        double _ImcResultado;
        double _FCresultado;
        double _Latidos;
        #endregion
        #region CONSTRUCTOR
        public VMexamen(INavigation navigation)
        {
            Navigation = navigation;
           

        }
        #endregion
        #region OBJETOS
        public double Latidos
        {
            get { return _Latidos; }
            set { SetValue(ref _Latidos, value); }
        }
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        public string Resultado
        {
            get { return _Resultado; }
            set { SetValue(ref _Resultado, value); }
        }
        public double Peso
        {
            get { return _Peso; }
            set { SetValue(ref _Peso, value); }
        }
        public bool Imc
        {
            get { return _Imc; }
            set { SetValue(ref _Imc, value); }
        }
        public double Altura
        {
            get { return _Altura; }
            set { SetValue(ref _Altura, value); }
        }
        public double ImcResultado
        {
            get { return _ImcResultado; }
            set { SetValue(ref _ImcResultado, value); }
        }
        public double FCResultado
        {
            get { return _FCresultado; }
            set { SetValue(ref _FCresultado, value); }
        }
        public bool FCN
        {
            get { return _FCN; }
            set { SetValue(ref _FCN, value); }
        }

        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }

        //public void Estados()
        //{
        //    if (Imc ==true)
        //    {
        //        IMCVisible= true;
        //    }
        //    else if (FCN ==true) 
        //    {
        //        FCVisible= true;
        //    }
        //}
        public void ImcMetodo()
        {
            ImcResultado= Peso/(Altura*Altura);

            if (ImcResultado < 18.5)
            {
                Resultado = "Peso insuficiente y tiene un imc de " + ImcResultado;
            }
            else if (ImcResultado >= 18.5 && ImcResultado <= 24.9)
            {
                Resultado = "Peso Normal y tiene un imc de " + ImcResultado;
            }
            else if (ImcResultado >= 25 && ImcResultado <= 29.9)
            {
                Resultado = "Sobrepeso y tiene un imc de " + ImcResultado;
            }
            else if (ImcResultado >= 30)
                Resultado = "Esta obeso y tiene un imc de " + ImcResultado;
        }
        public void Calcular()
        {
            if (Imc==true) 
            {
                ImcMetodo();
            }
            else if (FCN == true)
            {
                FCMetodo();
            }


        }
        public void FCMetodo() 
        {
            FCResultado = Latidos*4;
            if (FCResultado <60)
            {
                Resultado = "FC bajo y es de " + FCResultado;
            }
            else  if (FCResultado >=60 && FCResultado<=100)
                    {
                Resultado = "FC Normal y es de " + FCResultado;

            }
            else if (FCResultado >=100 )
            {
                Resultado = "FC Alto y es de " + FCResultado;
            }
        }
        public void procesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand Calcularcomand => new Command(Calcular);
        #endregion
    }
}
