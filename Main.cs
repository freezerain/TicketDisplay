using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Diagnostics.Debug;
namespace TicketDisplay
{
    public class Main
    {
        public Main()
        {
            WriteLine("This object was created");
        }
        
        public object[] ListaProcedimientos()
        {
            WriteLine("Event list registered");
            return new object[] { "Iniciar", "Finalizar", "AntesDeGuardarMaestro" , "AntesDeGuardarMaestroV2"
            ,"DespuesDeCargarDocumento", "ActivarMetodosAlServir", "SePuedeRealizarAccion"
            ,"AntesDeCambioDeCampoEnDocumentoProc", "AlValidarClienteProveedor", "DespuesDeGuardarLinea"
            ,/*"AntesDeGuardarDocumentoV2",*/ "DespuesDeGuardarDocumento", "DespuesDeCancelarDocumento",
            "DespuesDeGuardarEfecto", "DespuesDeGuardarRemesa", "DespuesDeGuardarAsiento"
            , "CamposAEscucharEnDocumento", "DespuesDeCambioDeCampoEnDocumento"
            };
        }

        object CamposAEscucharEnDocumento(string claseDocumento, float idDoc)
        {
            WriteLine("CamposAEscucharEnDocumento: " + claseDocumento + " "
                          + idDoc );
            return new object[] {2, "CABECERA.REFERENCIA", "LINEA.CODART"};
        }

        void DespuesDeCambioDeCampoEnDocumento(string claseDocumento, float idDoc, string
            campo, object valorAnterior, object nuevoValor)
        {
            WriteLine("DespuesDeCambioDeCampoEnDocumento: " + claseDocumento + " "
                      + idDoc + " " + campo+ " " + valorAnterior+ " " + nuevoValor);
        }


        void DespuesDeGuardarAsiento(float idAsiento, object asiento)
        {
            WriteLine("DespuesDeGuardarAsiento: " + idAsiento + " "
              + asiento );
        }

        void DespuesDeGuardarRemesa(string operacion, string tipo, float idRemesa)
        {
            WriteLine("DespuesDeGuardarRemesa: " + operacion + " "
              + tipo + " " + idRemesa);
        }

        void DespuesDeGuardarEfecto(string operacion, float numCartera, int numVen)
        {
            WriteLine("DespuesDeGuardarEfecto: " + operacion + " "
              + numCartera + " " + numVen );
        }

        void DespuesDeCancelarDocumento(string documento, double idDoc, object cabecera,
object lineas, int estado)
        {
            WriteLine("DespuesDeCancelarDocumento: " + documento + " "
              + idDoc + " "+ cabecera + " " + lineas + " " + estado );
        }

        void DespuesDeGuardarDocumento(string documento, double idDoc)
        {
            WriteLine("DespuesDeGuardarDocumento: " + documento + " "
              + idDoc);
        }

        /*
        bool AntesDeGuardarDocumentoV2(string documento, double idDoc, object cabecera,
object lineas, int estado)
        {
            System.Diagnostics.Debug.WriteLine("AntesDeGuardarDocumentoV2: " + documento + " "
              + idDoc + " " + cabecera);
            return true;
        }
        */

        void DespuesDeGuardarLinea(string tipoDocumento, object cabecera, object linea)
        {
            WriteLine("DespuesDeGuardarLinea: " + tipoDocumento + " "
               + cabecera + " " + linea );
        }

        void AntesDeCambioDeCampoEnDocumentoProc(string claseDocumento, float idDoc,
string campo, object valorAnterior, ref object nuevoValor)

        {
            WriteLine("AntesDeCambioDeCampoEnDocumentoProc: " + claseDocumento + " "
                + idDoc + " " + campo + " " + valorAnterior + " " + nuevoValor);
        }

        void SePuedeRealizarAccion(string TipoDocumento, double idDoc, int Accion, ref int
aRespuesta, ref string aMotivo)
        {
            WriteLine("SePuedeRealizarAccion: " + TipoDocumento + " "
                + idDoc + " " + Accion + " " + aRespuesta + " " + aMotivo);
        }

        bool ActivarMetodosAlServir()
        {
            WriteLine("ActivarMetodosAlServir ");
            return true;
        }

        void DespuesDeCargarDocumento(string tipoDoc, float IdDoc, object cabecera, object
lineas, int estado)
        {
            WriteLine("DespuesDeCargarDocumento: " + tipoDoc + " " 
                + IdDoc + " " + cabecera + " " + lineas + " " + estado);
        }

        bool AntesDeGuardarMaestroV2(string tabla, ref object datos, int estado)
        {
            WriteLine("AntesDeGuardarMaestroV2: " + tabla + " " + datos+ " "+ estado);
            return false;
        }

        bool AntesDeGuardarMaestro(string tabla, ref object datos)
        {
            WriteLine("AntesDeGuardarMaestro: " + tabla + " " + datos);
            return false;
        }

        public void Iniciar(string conexionSistema, string conexionEmpresa)
        {
            WriteLine("Init event with " + conexionEmpresa);
        }
        
        public void Finalizar()
        {
            WriteLine("Finilazed event");
        }
        
    }
}
