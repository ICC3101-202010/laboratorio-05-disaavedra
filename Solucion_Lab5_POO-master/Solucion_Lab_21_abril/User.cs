using System;
using System.Collections.Generic;
using System.Text;

namespace Solucion_Lab_21_abril
{
    class User
    {
        String eleccion;

        public delegate void EmailVerifiedEventHandler(object source, EventArgs args);

        public event EmailVerifiedEventHandler EmailVerified;

        protected virtual void OnEmailVerified()
        {
            if (EmailVerified != null)
                EmailVerified(this, EventArgs.Empty);
        }

        public void OnEmailSent(object source, EventArgs n)
        {
            Console.WriteLine("Desea verificar su mail?");
            eleccion = Console.ReadLine();
            if (eleccion == "Si")
                OnEmailVerified();                
        }

    }
}
