using System;
using System.Collections.Generic;
using UnityEngine;
namespace NotGame
{
    

public class Attack : MonoBehaviour
{
    public int countObj = 100;
    public List<ObjAttack> attackList = new List<ObjAttack>();
    public Action OnSpacePressed;

    private void Awake()
    {
        // Создаем объекты и добавляем их в список attackList
        for (var i = 0; i < countObj; i++)
        {
            var objAttack = new ObjAttack();
            attackList.Add(objAttack);
        }

        // Привязываем метод AtackMove каждого объекта к событию OnSpacePressed
        foreach (var objAttack in attackList)
        {
            OnSpacePressed += objAttack.AttackMove;
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            // Вызываем событие OnSpacePressed при нажатии на пробел
            OnSpacePressed?.Invoke();
        }
    }
}
[Serializable]
public class ObjAttack
{
    public void AttackMove()
    {
        Debug.Log("Пробел нажат!");
    }
}
}