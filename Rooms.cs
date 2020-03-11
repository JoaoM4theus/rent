using System;
using System.Collections.Generic;
using System.Text;

namespace Rent {
    class Rooms {
        public string Name { get; set; }
        public string Email { get; set; }

        public Rooms(string nome, string email) {
            Name = nome; Email = email;
        }

        public override string ToString() {
            return Name + ", " + Email;
        }
    }
}
