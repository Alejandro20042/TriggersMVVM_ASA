using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TriggersMVVM_ASA.VistaModelo;

namespace TriggersMVVM_ASA.Datos
{
    public class Dcategorias
    {
        public static ObservableCollection<Mcategorias> MostrarCategorias()
        {
            return new ObservableCollection<Mcategorias>()
            {
                new Mcategorias ()
                {
                    descripcion = "Cena",
                    numeroItem= 4512,
                    imagen="https://i.ibb.co/nz2jQLh/guino.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias ()
                {
                    descripcion = "Hotel",
                    numeroItem= 4512,
                    imagen="https://i.ibb.co/vvXnCW9/superestrella.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias ()
                {
                    descripcion = "Fiesta",
                    numeroItem= 4512,
                    imagen="https://i.ibb.co/5j3sTbn/risa.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias ()
                {
                    descripcion = "Flores",
                    numeroItem= 4512,
                    imagen="https://i.ibb.co/5j3sTbn/risa.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                }
            };
        }
    }
}
