namespace Banco
{
    public enum TipoExtraccion 
    {
        CajeroHumano = 1,
        CajeroAutomatico = 2
    }

    

    public class Cuenta
    {
        private TipoExtraccion Cajero;
        private int tipo;
        private float saldo;

        public int Tipo { get => tipo; set => tipo = value; }
        public float Saldo { get => saldo; set => saldo = value; }
        public TipoExtraccion Cajero1 { get => Cajero; set => Cajero = value; }

        public Cuenta () {}

        public Cuenta (int tipoCuenta, float saldoCuenta)
        {
            this.Tipo = tipoCuenta;
            this.Saldo = saldoCuenta;
        }
        
        public float Insercion(int monto){
            Saldo += monto;
            return Saldo;
        }

        public void Extraccion(int monto, TipoExtraccion Cajero)
        {

        }
    } 
}

