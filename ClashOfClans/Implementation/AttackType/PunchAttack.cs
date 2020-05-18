using System;
using System.Collections.Generic;
using System.Text;
using ClashOfClans.Interface;

namespace ClashOfClans.Implementation {
  class PunchAttack :IAttackType {
    public void Attack() {
      Console.WriteLine("I am gonna punch you so hard on your face.");
    }
  }
}
