﻿using System.Collections.Generic;
using System.Linq;

namespace Natasha
{
    public static class IEnumerableCloneExtension
    {
        public static IEnumerable<T> CloneExtension<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
            {
                return null;
            }

            return collection.Select(item => CloneOperator<T>.Clone(item));
        }

        public static IDictionary<TKey, TValue> CloneExtension<TKey, TValue>(this IDictionary<TKey, TValue> collection)
        {
            if (collection == null)
            {
                return null;
            }

            Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();
            foreach (var item in collection)
            {
                dictionary[CloneOperator<TKey>.Clone(item.Key)] = CloneOperator<TValue>.Clone(item.Value);
            }
            return dictionary;
        }

        public static IDictionary<TKey, TValue> OnlyKeyCloneExtension<TKey, TValue>(this IDictionary<TKey, TValue> collection)
        {
            if (collection == null)
            {
                return null;
            }

            Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();
            foreach (var item in collection)
            {
                dictionary[CloneOperator<TKey>.Clone(item.Key)] = item.Value;
            }
            return dictionary;
        }
        public static IDictionary<TKey, TValue> OnlyValueCloneExtension<TKey, TValue>(this IDictionary<TKey, TValue> collection)
        {
            if (collection == null)
            {
                return null;
            }

            Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();
            foreach (var item in collection)
            {
                dictionary[CloneOperator<TKey>.Clone(item.Key)] = item.Value;
            }
            return dictionary;
        }
    }

}