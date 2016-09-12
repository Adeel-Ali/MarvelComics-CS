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
    public class CharacterList : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int available;
        private string collectionURI;
        private List<CharacterSummary> items;
        private int returned;

        /// <summary>
        /// The number of total available characters in this list. Will always be greater than or equal to the "returned" value.
        /// </summary>
        [JsonProperty("available")]
        public int Available 
        { 
            get 
            {
                return this.available; 
            } 
            set 
            {
                this.available = value;
                onPropertyChanged("Available");
            }
        }

        /// <summary>
        /// The path to the full list of characters in this collection.
        /// </summary>
        [JsonProperty("collectionURI")]
        public string CollectionURI 
        { 
            get 
            {
                return this.collectionURI; 
            } 
            set 
            {
                this.collectionURI = value;
                onPropertyChanged("CollectionURI");
            }
        }

        /// <summary>
        /// The list of returned characters in this collection.
        /// </summary>
        [JsonProperty("items")]
        public List<CharacterSummary> Items 
        { 
            get 
            {
                return this.items; 
            } 
            set 
            {
                this.items = value;
                onPropertyChanged("Items");
            }
        }

        /// <summary>
        /// The number of characters returned in this collection (up to 20).
        /// </summary>
        [JsonProperty("returned")]
        public int Returned 
        { 
            get 
            {
                return this.returned; 
            } 
            set 
            {
                this.returned = value;
                onPropertyChanged("Returned");
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