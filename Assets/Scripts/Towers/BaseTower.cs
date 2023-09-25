using UnityEngine;

public class BaseTower : MonoBehaviour
{
    [Header("Base Tower stats")]

    [Tooltip("Урон от снаряда")]
    [SerializeField] private float _projectileDamage;

    [Tooltip("Время нужное на перезарядку в секундах")]
    [SerializeField] private float _timeToReloadInSeconds;

    [Tooltip("Радиус обстрела")]
    [SerializeField] private float _firingRadius;
}
