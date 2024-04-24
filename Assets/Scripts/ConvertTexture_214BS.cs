using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class ConvertTexture_214BS : MonoBehaviour
{
     async void Start()
     {
         //сюда закинуть путь папки в которой должны лежать все картинки
         List<string> filesPath_214BS = Directory.GetFiles("/Users/a1/Desktop/zaglushki").ToList();

         foreach (var filePath_214BS in filesPath_214BS)
         {
             StartCoroutine(Convert_214BS(filePath_214BS));
             await Task.Delay(50);
         }
         if (false)
         {
             while (false)
             {
                 var bs214 = SystemInfo.deviceName;
             }
         }
     }

    private IEnumerator Convert_214BS(string imagePath)
    {
        var readingTask_214BS = File.ReadAllBytesAsync(imagePath);

        while (!readingTask_214BS.IsCompleted)
        {
            yield return null;
        }

        byte[] data_214BS = readingTask_214BS.Result;

        Texture2D texture_214BS = new Texture2D(2, 2, TextureFormat.RGB24, false);

        texture_214BS.LoadImage(data_214BS);

        if (texture_214BS.width % 4 != 0 || texture_214BS.height % 4 != 0)// если при делении на 4 высоты или ширины текстуры есть остатакок
        {
            int sizeXShaders_214BS = texture_214BS.width - texture_214BS.width % 4;//отнимаем остаток от ширины
            int sizeYShaders_214BS = texture_214BS.height - texture_214BS.height % 4;//отнимаем остаток от высоты
            var newPixels_214BS = texture_214BS.GetPixels(0, 0, sizeXShaders_214BS, sizeYShaders_214BS);//сохраняем пиксели текстуры размером кратным 4
            texture_214BS.Reinitialize(sizeXShaders_214BS, sizeYShaders_214BS);//меняем размер текстуры кратным 4
            texture_214BS.SetPixels(newPixels_214BS);//перезаписываем пиксели
            texture_214BS.Apply(false, false);//сохраняем изменения
        }

        texture_214BS.Compress(false);
        texture_214BS.Apply(false, false);

        //Получаю из текстуры массив байтов
        byte[] dataBytes_214BS = texture_214BS.GetRawTextureData();

        //Делаю новый массив на 8 байтов больше
        byte[] dataBytesWithSize_214BS = new byte[dataBytes_214BS.Length + 8];
        //...копирую в него предыдущий
        Array.Copy(dataBytes_214BS, dataBytesWithSize_214BS, dataBytes_214BS.Length);

        //Перегоняю ширину и высоту в байтовые массивы
        byte[] width_214BS = BitConverter.GetBytes(texture_214BS.width);
        byte[] height_214BS = BitConverter.GetBytes(texture_214BS.height);


        //запиываю в последние 8 байт последнего массива высоту и ширину побайтово
        dataBytesWithSize_214BS[dataBytesWithSize_214BS.Length - 8] = width_214BS[0];
        dataBytesWithSize_214BS[dataBytesWithSize_214BS.Length - 7] = width_214BS[1];
        dataBytesWithSize_214BS[dataBytesWithSize_214BS.Length - 6] = width_214BS[2];
        dataBytesWithSize_214BS[dataBytesWithSize_214BS.Length - 5] = width_214BS[3];
        dataBytesWithSize_214BS[dataBytesWithSize_214BS.Length - 4] = height_214BS[0];
        dataBytesWithSize_214BS[dataBytesWithSize_214BS.Length - 3] = height_214BS[1];
        dataBytesWithSize_214BS[dataBytesWithSize_214BS.Length - 2] = height_214BS[2];
        dataBytesWithSize_214BS[dataBytesWithSize_214BS.Length - 1] = height_214BS[3];


        if (!File.Exists("/Users/a1/Desktop/zaglushki/11"))
        {
            Directory.CreateDirectory("/Users/a1/Desktop/zaglushki/11");
        }
        
        string filePathToSave_214BS = $"{"/Users/a1/Desktop/zaglushki/11"}/{Path.GetFileName(imagePath)}";

        //Сохраняю файл
        File.WriteAllBytes(filePathToSave_214BS, dataBytesWithSize_214BS);
    }
}
