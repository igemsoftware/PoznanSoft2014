﻿using Bio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mufasa.BackEnd.Designer
{
    /// <remarks>
    /// DNA fragment class.
    /// </remarks>
    class Fragment
    {
        /// <value>
        /// Path to the file or url containing the fragment.
        /// </value>
        public String Source { get; set; }
        /// <summary>
        /// Name of the fragment.
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// Fragment sequence.
        /// </summary>
        public ISequence Sequence { get; set; }

        /// <summary>
        /// Fragment constructor.
        /// </summary>
        /// <param name="source">Filename or URL.</param>
        /// <param name="name">Fragment name.</param>
        public Fragment(String source, String name, ISequence sequence)
        {
            this.Source = source;
            this.Name = name;
            this.Sequence = sequence;
        }

        /// <summary>
        /// Fragment constructor.
        /// </summary>
        public Fragment()
        {
        }

        /// <summary>
        /// Copying Fragment constructor.
        /// </summary>
        public Fragment(Fragment frag)
        {
            this.Name = frag.Name;
            this.Sequence = new Sequence(frag.Sequence);
            this.Source = frag.Source;
        }

        /// <summary>
        /// Returns full fragment sequence as a string. Based on .NET Bio Programming Guide.
        /// </summary>
        /// <returns>Sequence string.</returns>
        public string GetString()
        {
            char[] symbols = new char[this.Sequence.Count];
            for (long index = 0; index < this.Sequence.Count; index++)
            {
                symbols[index] = (char)this.Sequence[index]; 
            }
            return new String(symbols); 
        }

        /// <summary>
        /// Returns full fragment reverse complement sequence as a string.
        /// </summary>
        /// <returns>Reverse complement sequence string.</returns>
        public string GetReverseComplementString()
        {
            ISequence revComp = this.Sequence.GetReverseComplementedSequence();
            char[] symbols = new char[revComp.Count];
            for (long index = 0; index < revComp.Count; index++)
            {
                symbols[index] = (char)revComp[index];
            }
            return new String(symbols); 
        }
    }
}
