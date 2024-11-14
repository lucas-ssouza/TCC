using UnityEngine;
using System.Collections;

public interface ICharacter: IIdentifiable
{	
    int Health { get;    set;}

    int Attack { get;    set;} // tirar se pa

    void Die();
}

public interface IIdentifiable
{
    int ID { get; }
}
