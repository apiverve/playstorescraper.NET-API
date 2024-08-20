using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class histogram
{
    [JsonProperty("1")]
    public int 1 { get; set; }

    [JsonProperty("2")]
    public int 2 { get; set; }

    [JsonProperty("3")]
    public int 3 { get; set; }

    [JsonProperty("4")]
    public int 4 { get; set; }

    [JsonProperty("5")]
    public int 5 { get; set; }

}

public class categories
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("id")]
    public string id { get; set; }

}

public class data
{
    [JsonProperty("title")]
    public string title { get; set; }

    [JsonProperty("description")]
    public string description { get; set; }

    [JsonProperty("descriptionHTML")]
    public string descriptionHTML { get; set; }

    [JsonProperty("summary")]
    public string summary { get; set; }

    [JsonProperty("installs")]
    public string installs { get; set; }

    [JsonProperty("minInstalls")]
    public int minInstalls { get; set; }

    [JsonProperty("maxInstalls")]
    public int maxInstalls { get; set; }

    [JsonProperty("score")]
    public double score { get; set; }

    [JsonProperty("scoreText")]
    public string scoreText { get; set; }

    [JsonProperty("ratings")]
    public int ratings { get; set; }

    [JsonProperty("reviews")]
    public int reviews { get; set; }

    [JsonProperty("histogram")]
    public histogram histogram { get; set; }

    [JsonProperty("price")]
    public int price { get; set; }

    [JsonProperty("free")]
    public bool free { get; set; }

    [JsonProperty("currency")]
    public string currency { get; set; }

    [JsonProperty("priceText")]
    public string priceText { get; set; }

    [JsonProperty("available")]
    public bool available { get; set; }

    [JsonProperty("offersIAP")]
    public bool offersIAP { get; set; }

    [JsonProperty("androidVersion")]
    public string androidVersion { get; set; }

    [JsonProperty("androidVersionText")]
    public string androidVersionText { get; set; }

    [JsonProperty("androidMaxVersion")]
    public string androidMaxVersion { get; set; }

    [JsonProperty("developer")]
    public string developer { get; set; }

    [JsonProperty("developerId")]
    public string developerId { get; set; }

    [JsonProperty("developerEmail")]
    public string developerEmail { get; set; }

    [JsonProperty("developerWebsite")]
    public string developerWebsite { get; set; }

    [JsonProperty("developerAddress")]
    public string developerAddress { get; set; }

    [JsonProperty("privacyPolicy")]
    public string privacyPolicy { get; set; }

    [JsonProperty("developerInternalID")]
    public string developerInternalID { get; set; }

    [JsonProperty("genre")]
    public string genre { get; set; }

    [JsonProperty("genreId")]
    public string genreId { get; set; }

    [JsonProperty("categories")]
    public categories[] categories { get; set; }

    [JsonProperty("icon")]
    public string icon { get; set; }

    [JsonProperty("headerImage")]
    public string headerImage { get; set; }

    [JsonProperty("screenshots")]
    public string[] screenshots { get; set; }

    [JsonProperty("contentRating")]
    public string contentRating { get; set; }

    [JsonProperty("adSupported")]
    public bool adSupported { get; set; }

    [JsonProperty("updated")]
    public int updated { get; set; }

    [JsonProperty("version")]
    public string version { get; set; }

    [JsonProperty("recentChanges")]
    public string recentChanges { get; set; }

    [JsonProperty("comments")]
    public object[] comments { get; set; }

    [JsonProperty("preregister")]
    public bool preregister { get; set; }

    [JsonProperty("earlyAccessEnabled")]
    public bool earlyAccessEnabled { get; set; }

    [JsonProperty("isAvailableInPlayPass")]
    public bool isAvailableInPlayPass { get; set; }

    [JsonProperty("appId")]
    public string appId { get; set; }

    [JsonProperty("url")]
    public string url { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
