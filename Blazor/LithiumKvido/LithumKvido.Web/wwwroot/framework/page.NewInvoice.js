class NewInvoicePage extends PageBase {


    constructor() {
        super();
        this.name = 'ninvoice';

        // init datetimepicker lib
        $.datetimepicker.setDateFormatter('moment');
    }

    init() {

        // init datetimepicker
        $('.datetimepicker').each(function (){
            var elem = $(this);
            $(this).datetimepicker({
                timepicker:false,
                format:'m/d/Y',
                onChangeDateTime:function(dp,$input){
                    console.log('ccc');
                    
                    // quickfix
                    $('input[model-val=' + elem.attr('model') + ']').val(elem.val());
                    elem.trigger('change');
                }
            });
        });
    }
    
    getDate(modelName){
        return $(`.datetimepicker[identifier=${modelName}]`).val();
    }


}