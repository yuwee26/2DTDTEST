using UnityEngine;

public class BaseTower : MonoBehaviour
{
    [Header("Base Tower stats")]

    [Tooltip("���� �� �������")]
    [SerializeField] private float _projectileDamage;

    [Tooltip("����� ������ �� ����������� � ��������")]
    [SerializeField] private float _timeToReloadInSeconds;

    [Tooltip("������ ��������")]
    [SerializeField] private float _firingRadius;
}
