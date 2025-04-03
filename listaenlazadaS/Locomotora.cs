using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaenlazadaS{
    class Locomotora{
        Vagon Primero { get; set; }

        public void AgregaPrimero(int valor){
            Vagon nuevo = new Vagon(valor);
            if (this.Primero == null)//caso 1
            {
                this.Primero = nuevo;
            }
            else //caso 2
            {
                Vagon primVag = this.Primero;

                nuevo.Sig = primVag;
                
                this.Primero = nuevo;
                
            }

        }


        public void AgregaFinal(int valor){
            Vagon nuevo = new Vagon(valor);
            if (this.Primero == null)//caso 1
            {
                this.Primero = nuevo;
            }
            else //caso 2
            {
                Vagon tmp = this.Primero;
                while (tmp.Sig != null)
                {
                    tmp = tmp.Sig;
                }
                tmp.Sig = nuevo;
            }
        }
        public void EliminaUltimo(){
            if (this.Primero == null) // Caso 1: La lista está vacía
            {
                return;
            }

            if (this.Primero.Sig == null) // Caso 2: Solo hay un vagón
            {
                this.Primero = null;
                return;
            }

            Vagon tmp = this.Primero;
            while (tmp.Sig.Sig != null) // Recorremos hasta el penúltimo vagón
            {
                tmp = tmp.Sig;
            }
            tmp.Sig = null; // Eliminamos el último vagón
        }

        public int Largo() {
            return 0;
        }

        public int GetValor(int pos) {
            return 0;
        }

        public void AgregaLEFinal(Locomotora otro) {

        }

        public void Ordena() {

        }

        public bool ExisteValor(int valor) {
            Vagon tmp = this.Primero;
            while (tmp != null) {
                if ( tmp.Dato == valor) {
                    return true;
                }
                tmp = tmp.Sig;
            }
            return false;
        }
        public string VerVagones(){
            string listaVag = "";
            Vagon tmp = this.Primero;
            while (tmp != null) {
                listaVag += tmp.Dato + ", ";
                tmp = tmp.Sig;
            }
            return listaVag;
        }
    }
}
