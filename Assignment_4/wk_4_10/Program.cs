using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk_4_10
{

    [Flags]
    enum FilePermission
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            FilePermission userPermissions = FilePermission.Read | FilePermission.Write;

            bool hasWritePermission = (userPermissions & FilePermission.Write) == FilePermission.Write;

            Console.WriteLine($"User has Read permission: {(userPermissions & FilePermission.Read) == FilePermission.Read}");
            Console.WriteLine($"User has Write permission: {hasWritePermission}");
            Console.WriteLine($"User has Execute permission: {(userPermissions & FilePermission.Execute) == FilePermission.Execute}");
        }
    }

}
