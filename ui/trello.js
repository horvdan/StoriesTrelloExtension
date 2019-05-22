console.log("hello?")

TrelloPowerUp.initialize({
    'board-buttons': function(t, options){
      return [{
        icon: 'https://img.icons8.com/office/16/000000/billboard.png',
        text: 'Storyboard',
        callback: function(t){
          return t.modal({
            title: "Storyboard",
            url: 'index.html',
            fullscreen: true
          });
        }
      }];
    }
  });
