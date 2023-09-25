using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    [Header("Base Enemy stats")]
    [SerializeField] private float _enemyHealth;
    [SerializeField] private float _enemyMoveSpeed;
    [Tooltip("���������� �����, ������� �������� ����� ���� ��������� �����")]
    [SerializeField] private int _enemyValue;
}
