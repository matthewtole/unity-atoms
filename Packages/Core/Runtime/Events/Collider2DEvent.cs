using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collider2D", fileName = "Collider2DEvent")]
    public sealed class Collider2DEvent : AtomEvent<Collider2D> { }
}