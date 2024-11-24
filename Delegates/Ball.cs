using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Ball
    {
        public int Id { get; set; }

		private Location location;

        public Ball(int id)
        {
            Id = id;
        }

        public Location Location
        {
			get => location ; 
			set {
				
				if (!value.Equals(location))
				{
					location = value;

					LocationChanged?.Invoke();
				}

            }
		}

		public event Action? LocationChanged ;

	}
}
