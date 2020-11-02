class IndexPage extends PageBase {


    constructor() {
        super();
        this.name = 'index';
        
        // init datetimepicker lib
        $.datetimepicker.setDateFormatter('moment');
    }

    init() {
        
        // init select2
        $('.s2').each(function () {
            $(this).select2();
        });
        
        // init datetimepicker
        $('.datetimepicker').each(function (){
            $(this).datetimepicker({
                timepicker:false,
                format:'MM/DD/YYYY'
            });
        });
    }
    
    // get InvoiceFilterModel based from select2 
    getFilterData(){
        var result = {};
        
        // get selected values from select2
        $('.s2').each(function(){
           var model = $(this).attr('model');
           if(typeof model === 'undefined')
               return;

           var array = [];
           $(this).select2('data').forEach((e) => {
            array.push(parseInt(e.id));     
           });
           
           if(array.length > 0)
               result[model] = array;
           
        });
        
        // get input values
        $('input').each(function(){
            var model = $(this).attr('model');
            if(typeof model === 'undefined' || $(this).val() == '')
                return;
            
            result[model] = $(this).val();
        });
        
        return result;
    }

}