using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class RoleAddLogic
    {
        Position _position;

        public void setPosition(Position position)
        {
            _position = position;
        }

        public void createPosition()
        {
            _position = new Position();
        }

        public void setPositionName(Context context, string name)
        {
            name.Replace(" ", string.Empty);

            if(name != "")
            {
                _position.Name = name;
            }
        }

        public Position GetPosition()
        {
            return _position;
        }
    }
}
