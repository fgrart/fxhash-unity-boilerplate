// this defines the function that we call in our c# code, it returns the FxhashRandom() function from the index.html
var plugin = {
  GetRandomFromFxhash: function () 
  {
    return FxhashRandom();
  },
};

mergeInto(LibraryManager.library, plugin);

    