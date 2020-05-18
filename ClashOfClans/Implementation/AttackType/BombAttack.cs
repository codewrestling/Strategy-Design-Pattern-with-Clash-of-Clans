using System;
using System.Collections.Generic;
using System.Text;
using ClashOfClans.Interface;

namespace ClashOfClans.Implementation {
  class BombAttack : IAttackType {
    public void Attack() {
      Console.WriteLine("My bombs will destroy everything.");
    }
  }
}
