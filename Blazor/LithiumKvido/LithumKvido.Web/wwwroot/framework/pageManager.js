class PageManager {
    
    constructor(){
        this.pages = [];
    }
    
    addPage(name, obj){
        this.pages[name] = obj; 
    }
    
    // called from blazor pages after render
    call(pageName, method){
        if(typeof this.pages[pageName] === 'undefined')
            return;
        
        if(typeof method === 'undefined')
            method = 'call';
        
        return this.pages[pageName][method]();
    }
    
}

class PageBase{
    
    constructor(){
        this.name = '';
        this.isInitialized = false;    
    }
    
    call(){
        if(!this.isInitialized)
        {
            this.init();
            this.isInitialized = false;
        }
    }
    
    init(){}
    
}