using System;
using System.Collections.Generic;
using System.Text;
using ClashOfClans.Interface;

namespace ClashOfClans.Implementation.Movement {
  class GroundMovement: IMovement {
    public void Move() {
      Console.WriteLine("I am gonna attack from Ground.");
    }
  }
}
