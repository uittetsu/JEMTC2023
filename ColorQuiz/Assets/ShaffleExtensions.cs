using System.Collections.Generic;
using UnityEngine;

public static class ShuffleExtensions
{
    /// <summary>
    /// �w�肳�ꂽ�v�f�̔z����V���b�t������
    /// </summary>
    public static void Shuffle<T>(this IList<T> array)
    {
        for (var i = array.Count - 1; i > 0; --i)
        {
            // 0�ȏ�i�ȉ��̃����_���Ȑ������擾
            // Random.Range�̍ő�l�͑�Q���������Ȃ̂ŁA+1���邱�Ƃɒ���
            var j = Random.Range(0, i + 1);

            // i�Ԗڂ�j�Ԗڂ̗v�f����������
            var tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
    }
}