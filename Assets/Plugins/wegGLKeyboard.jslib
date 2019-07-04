mergeInto(LibraryManager.library, {
    focusHandleAction: function(_name, _str){
        if(UnityLoader.SystemInfo.mobile == true){
            var _inputTextData = prompt("", Pointer_stringify(_str));
            if (_inputTextData == null || _inputTextData == "") {
                // cancel
            } else {
                // send
                SendMessage(Pointer_stringify(_name), 'ReceiveInputData', _inputTextData);
            }  
        }
    },
});