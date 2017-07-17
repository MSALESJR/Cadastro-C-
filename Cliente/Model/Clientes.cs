using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Model
{
    class ClientesDao
    {
        public List<Cliente.Entity.Cliente> Clientes { get; set; }

        public ClientesDao()
        {
            this.Clientes = new List<Cliente.Entity.Cliente>();
        }

        public void Add(Cliente.Entity.Cliente c)
        {
            this.Clientes.Add(c);
        }

        public int Count()
        {
            return this.Clientes.Count;
        }

        public List<Cliente.Entity.Cliente> All() {
            return this.Clientes;
        }
    }
}
