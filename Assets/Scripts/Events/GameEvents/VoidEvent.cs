using UnityEngine;

[CreateAssetMenu(fileName = "New Void Event", menuName = "Game Events/Void Event")]
public class VoidEvent : GameEvent<Void>
{
    public void Raise() => Raise(new Void());
}
