using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T>
    {
        T[] piece;
        T[] tempPiece;

        //constructor'umuza bu class çalıştığı zaman
        //bir tane piece isimli 0 elemanlı bir dizi oluşturmasını istedik
        public MyDictionary()
        {
            piece = new T[0];
        }

        public void Add(T thing)
        {
            //piece isimli tabloya yeni bir veri eklenmek istendiği 
            //zaman öncelikle piece isimli dizide bulunan geçici oluşturduğumuz
            //tempPiece adlı diziye taşıyoruz
            //daha sonra piece isimli dizinin uzunluğunu 1 arttırıyoruz
            tempPiece = piece;
            piece = new T[piece.Length + 1];
            //tempPiece isimlidizinin i. elemanını piece dizisinin i. elemanına atıyoruz
            for (int i = 0; i < tempPiece.Length; i++)
            {
                piece[i] = tempPiece[i];
            }
            piece[piece.Length - 1] = thing;
        }
        public int Count
        {
            get { return piece.Length; }
        }
    }
}
