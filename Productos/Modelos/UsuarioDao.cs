using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.Modelos
{
    public class UsuarioDao
    {
        public String[] users =
            {"engels", "dominik", "oscar"};
        public String[] pws =
        {
            "123", "147", "159";
            public Boolean Validar(String user, String pw)
        {
            for(int i = 0; i < users.Length; i++)
            {
                if (user[i].Equals(pw) && pws[i].Equals(pw))
                {
                    return true;
                }
                return false;
            }
        }
        };
    }
}
