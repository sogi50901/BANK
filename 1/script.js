(function(){

	$('html').addClass('js');

	var contactForm = {

		container : $('#contact') ,
        config: {
        	effect : 'slideToggle', //agar bashe hide va agar nabashe shox mikone
        	speed: 800 

        },


		init : function(config ){
			//console.log ('init is called');
			//console.log(this);
			$.extend(this.config , config);
			$('<button></button>' , {
				text: 'Contact Me' 

			}).insertAfter('article:first').on('click' ,  this.show);		
		},
		show: function(){
			//console.log('shoxing...');
			var cf= contactForm , container=cf.container , config= cf.config ;
			//container[config.effect](config.speed);  
	        //container.slideToggle(200);
	        if (container.is(':hidden')) {
	       container.show();
	       cf.close.call(container);

            }
		},
		close : function() {
               
                 config = contactForm.config;
                 if ($(this).find('span.close').length) return ;
				$('<span class="close"> X </span>')
				      .prependTo(this)
				      .on('click' , function() {
				      	$(this) [config.effect](config.speed);	
				      });

		}

	}

	contactForm.init({

             effect : 'slideToggle',
             	speed: 800
	});
	
})();