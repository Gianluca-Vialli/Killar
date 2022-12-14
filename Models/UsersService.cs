using System;
using System.Collections.Generic;
using System.Linq;


namespace Killar.Models
{
    public class UsersService
    {
        public void AddUser(Users newUser)
        {
            using (KillarContext dataBase = new KillarContext())
            {

                newUser.Password = Cryptography.EncryptedText(newUser.Password); // Utiliza a classe de criptografia para transformar em Hash MD5 o valor digitado no campo senha ao cadastrar o usuário;

                newUser.CheckedPassword = Cryptography.EncryptedText(newUser.CheckedPassword); // Utiliza a classe de criptografia para transformar em Hash MD5 o valor digitado no campo Senha Verificada ao cadastrar o usuário;

                dataBase.Usuarios.Add(newUser); // Adiciona na tabela usuários os dados registrados;

                dataBase.SaveChanges(); // Salva as alterações;

            }
        }

        public Users ListUser(int id)
        {
            using (KillarContext dataBase = new KillarContext())
            {
                return dataBase.Usuarios.Find(id);
            }
        }

        public void EditUser(Users editUser)
        {
            using (KillarContext dataBase = new KillarContext())
            {
                Users u = dataBase.Usuarios.Find(editUser.Id);
                u.Name = editUser.Name;
                u.BirthDate = editUser.BirthDate;
                u.LoginWr = editUser.LoginWr;
                u.LoginName = editUser.LoginName;
                u.Password = Cryptography.EncryptedText(editUser.Password);
                u.CheckedPassword = Cryptography.EncryptedText(editUser.CheckedPassword);
                u.Lane = editUser.Lane;
                u.Elo = editUser.Elo;
                u.Tipo = editUser.Tipo;

                dataBase.SaveChanges();
            }

        }

        public void DeleteUser(int id)
        {
            using (KillarContext dataBase = new KillarContext())
            {
                Users FoundUser = dataBase.Usuarios.Find(id);

                dataBase.Usuarios.Remove(FoundUser);
                dataBase.SaveChanges();
            }
        }

        public void EditUserProfile(Users editUser)
        {
            using (KillarContext dataBase = new KillarContext())
            {
                Users u = dataBase.Usuarios.Find(editUser.Id);
                u.Name = editUser.Name;
                u.BirthDate = editUser.BirthDate;
                u.LoginWr = editUser.LoginWr;
                u.LoginName = editUser.LoginName;
                u.Password = Cryptography.EncryptedText(editUser.Password);
                u.CheckedPassword = Cryptography.EncryptedText(editUser.CheckedPassword);
                u.Lane = editUser.Lane;
                u.Elo = editUser.Elo;
                u.Tipo = editUser.Tipo;

                dataBase.SaveChanges();
            }
        }

        public List<Users> ProfileUser(int id)
        {
            using (KillarContext dataBase = new KillarContext())
            {

                List<Users> UserList = new List<Users>();
                Users UserFound = dataBase.Usuarios.Where(p => p.Id == id).SingleOrDefault();
                UserList.Add(UserFound);

                return UserList;

            }
        }

        public Users SearchForId(int id)
        {
            using (KillarContext dataBase = new KillarContext())
            {
                return dataBase.Usuarios.Find(id);
            }
        }

        public int CountRegister()
        {
            using (KillarContext dataBase = new KillarContext())
            {
                return dataBase.Usuarios.Count();
            }
        }

        public ICollection<Users> GetUsers(string q, int page, int size) // Método de paginação
        {
            using (KillarContext dataBase = new KillarContext())
            {
                int jump = (page - 1) * size;
                IQueryable<Users> query = dataBase.Usuarios.Where(u => u.Name.Contains(q, StringComparison.OrdinalIgnoreCase));

                if (q != null)
                {

                    query = query.OrderBy(u => u.Name);

                }

                return query.Skip(jump).Take(size).ToList();

            }
        }

    }
}