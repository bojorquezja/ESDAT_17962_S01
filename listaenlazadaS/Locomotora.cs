using System;
using System.Collections.Generic;
using System.Drawing;
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
            if (this.Primero == null) {
                return 0;
            } else {
                int cant = 0;
                Vagon tmp = this.Primero;
                while (tmp != null) {
                    cant++;
                    tmp = tmp.Sig;
                }
                return cant;
            }
        }

        public int GetValor(int pos) {
            int indice = 0;
            Vagon tmp = this.Primero;
            while (tmp != null) {
                if (indice == pos) {
                    return tmp.Dato;
                }
                indice++;
                tmp = tmp.Sig;
            }
            return int.MinValue;
        }

        public void SetValor(int pos, int valor) {
            int indice = 0;
            Vagon tmp = this.Primero;
            while (tmp != null) {
                if (indice == pos) {
                    tmp.Dato = valor;
                }
                indice++;
                tmp = tmp.Sig;
            }
        }

        public void AgregaLEFinal(Locomotora otro) {
            for (int x = 0; x< otro.Largo(); x++) {
                this.AgregaFinal(otro.GetValor(x));
            }
        }

        public void Ordena() {
            for (int x = 0; x < this.Largo(); x++) {
                for (int pos = 0; pos < this.Largo() - 1;pos++) {
                    if (this.GetValor(pos) > this.GetValor(pos +1)) {
                        int temporal = this.GetValor(pos);
                        this.SetValor(pos, this.GetValor(pos + 1)) ;
                        this.SetValor(pos + 1, temporal);
                    }
                }
            }
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
