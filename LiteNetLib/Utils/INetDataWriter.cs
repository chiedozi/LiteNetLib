using System.Collections.Generic;
using System.Net;
using UnityEngine;

namespace LiteNetLib.Utils
{
    public interface INetDataWriter
    {
        byte[] Data { get; }
        int Length { get; }
        void ResizeIfNeed(int newSize);
        void Reset(int size);
        void Reset();
        byte[] CopyData();
        void Put(float value);
        void Put(double value);
        void Put(long value);
        void Put(ulong value);
        void Put(int value);
        void Put(uint value);
        void Put(char value);
        void Put(ushort value);
        void Put(short value);
        void Put(sbyte value);
        void Put(byte value);
        void Put(byte[] data, int offset, int length);
        void Put(byte[] data);
        void PutSBytesWithLength(sbyte[] data, int offset, int length);
        void PutSBytesWithLength(sbyte[] data);
        void PutBytesWithLength(byte[] data, int offset, int length);
        void PutBytesWithLength(byte[] data);
        void Put(bool value);
        void PutArray(float[] value);
        void PutArray(double[] value);
        void PutArray(long[] value);
        void PutArray(ulong[] value);
        void PutArray(int[] value);
        void PutArray(uint[] value);
        void PutArray(ushort[] value);
        void PutArray(short[] value);
        void PutArray(bool[] value);
        void PutArray(string[] value);
        void PutArray(string[] value, int maxLength);
        void PutArray<T>(T[] items) where T : INetSerializable, new();
        void PutArray<T>(T[] items, int count) where T : INetSerializable, new();
        void PutList<T>(List<T> list) where T : INetSerializable, new();
        void PutList(List<string> list);
        void Put(IPEndPoint endPoint);
        void Put(string value);
        void Put(string value, int maxLength);
        void Put<T>(T obj) where T : INetSerializable;
        void PutVector2(Vector2 vector);
        void PutVector3(Vector3 vector);
    }
}