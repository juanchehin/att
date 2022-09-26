using att.CapaDatos;

namespace att.CapaLogica
{
    public class LUsuarios
    {
        public static string Login(string usuario, string password)
        {
            DUsuarios Obj = new DUsuarios();
            Obj.Usuario = usuario;
            Obj.Password = password;
            return Obj.Login(Obj);
        }
    }
}
