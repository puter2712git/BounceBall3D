using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISteppable {
  void Stepped(Collision player);
}
