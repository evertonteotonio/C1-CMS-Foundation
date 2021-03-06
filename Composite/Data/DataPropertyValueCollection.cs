﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;


namespace Composite.Data
{
    /// <summary>    
    /// </summary>
    /// <exclude />
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)] 
	public sealed class DataPropertyValueCollection
	{
        private Dictionary<PropertyInfo, object> _propertyValues = new Dictionary<PropertyInfo, object>();


        /// <exclude />
        public void AddKeyProperty(PropertyInfo propertyInfo, object value)
        {
            if (propertyInfo == null) throw new ArgumentNullException("keyPropertyName");
            if (value == null) throw new ArgumentNullException("value");

            if (_propertyValues.ContainsKey(propertyInfo)) throw new ArgumentException(string.Format("The key property name '{0}' has already been added", propertyInfo.Name));

            _propertyValues.Add(propertyInfo, value);
        }



        /// <exclude />
        public IEnumerable<KeyValuePair<PropertyInfo, object>> PropertyValues
        {
            get
            {
                foreach (KeyValuePair<PropertyInfo, object> kvp in _propertyValues)
                {
                    yield return kvp;
                }
            }
        }
	}
}
