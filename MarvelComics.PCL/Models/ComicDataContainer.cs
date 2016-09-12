/*
 * MarvelComics.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 09/12/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MarvelComics.PCL;

namespace MarvelComics.PCL.Models
{
    public class ComicDataContainer : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int count;
        private int limit;
        private int offset;
        private List<Comic> results;
        private int total;

        /// <summary>
        /// The total number of results returned by this call.
        /// </summary>
        [JsonProperty("count")]
        public int Count 
        { 
            get 
            {
                return this.count; 
            } 
            set 
            {
                this.count = value;
                onPropertyChanged("Count");
            }
        }

        /// <summary>
        /// The requested result limit.
        /// </summary>
        [JsonProperty("limit")]
        public int Limit 
        { 
            get 
            {
                return this.limit; 
            } 
            set 
            {
                this.limit = value;
                onPropertyChanged("Limit");
            }
        }

        /// <summary>
        /// The requested offset (number of skipped results) of the call.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset 
        { 
            get 
            {
                return this.offset; 
            } 
            set 
            {
                this.offset = value;
                onPropertyChanged("Offset");
            }
        }

        /// <summary>
        /// The list of comics returned by the call
        /// </summary>
        [JsonProperty("results")]
        public List<Comic> Results 
        { 
            get 
            {
                return this.results; 
            } 
            set 
            {
                this.results = value;
                onPropertyChanged("Results");
            }
        }

        /// <summary>
        /// The total number of resources available given the current filter set.
        /// </summary>
        [JsonProperty("total")]
        public int Total 
        { 
            get 
            {
                return this.total; 
            } 
            set 
            {
                this.total = value;
                onPropertyChanged("Total");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 