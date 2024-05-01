using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFundamentos.src.Models.Base
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
        }

        private DateTime? _createdAt;

        public DateTime? CreatedAt
        {
            get => _createdAt;
            set => _createdAt = value ?? DateTime.UtcNow;
        }

        public DateTime? _exitedAt { get; set; }

        public DateTime? ExitedAt
        {
            get => _exitedAt;
            set => _exitedAt = value ?? DateTime.UtcNow;
        }
    }
}
