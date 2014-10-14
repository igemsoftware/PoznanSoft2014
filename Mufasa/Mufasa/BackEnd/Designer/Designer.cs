﻿using Mufasa.BackEnd.Exceptions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bio;

namespace Mufasa.BackEnd.Designer
{
    class Designer
    {
        /// <summary>
        /// Designer constructor.
        /// </summary>
        public Designer()
        {
            FragmentList = new ObservableCollection<Fragment>();
            FragmentNames = new ObservableCollection<String>();
        }

        /// <summary>
        /// List of fragments.
        /// </summary>
        public ObservableCollection<Fragment> FragmentList { get; set; }

        /// <summary>
        /// List of fragment simple names.
        /// </summary>
        public ObservableCollection<String> FragmentNames { get; set; }

        /// <summary>
        /// Add Fragment <paramref name="name"/> if valid.
        /// </summary>
        /// <param name="file">Fragment filename</param>
        /// <param name="name">Fragment name</param>
        public void AddFragment(String file, String name)
        {
            if (this.FragmentNames.Contains(name))
            {
                throw new FragmentNamingException(name);
            }
            this.FragmentNames.Add(name);
            this.FragmentList.Add(new Fragment(file, name));
        }


    }
}


