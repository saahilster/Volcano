using System;
using UnityEngine;

public interface IBattler
{
    void Action(IBattler target);
    void Item(IBattler target);
}
