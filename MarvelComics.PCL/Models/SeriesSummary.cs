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
    public class SeriesSummary : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string name;
        private string resourceURI;

        /// <summary>
        /// The canonical name of the series.
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// The path to the individual series resource.
        /// </summary>
        [JsonProperty("resourceURI")]
        public string ResourceURI 
        { 
            get 
            {
                return this.resourceURI; 
            } 
            set 
            {
                this.resourceURI = value;
                onPropertyChanged("ResourceURI");
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