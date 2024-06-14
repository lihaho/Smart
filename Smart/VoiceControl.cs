using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart
{
    public class VoiceControl
    {
        private BaiduAIHelper _baiduAIHelper;
        private ChatGPTHelper _chatGPTHelper;
        private Smart _mainForm;

        public VoiceControl(BaiduAIHelper baiduAIHelper, ChatGPTHelper chatGPTHelper,  Smart mainForm)
        {
            _baiduAIHelper = baiduAIHelper;
            _chatGPTHelper = chatGPTHelper;
            _mainForm = mainForm;
        }

        public string ProcessCommand(string command)
        {
            // string response = "我没听清，能再说一遍吗？";
            string response = "";
            if (command.Contains("离家模式"))
            {
                response = "已执行离家模式";
                _mainForm.RunDeviceMod("离家");
            }
            
            string room = "客厅";
            if (command.Contains("主卧"))
            {
                room = "主卧";
            } else if (command.Contains("次卧"))
            {
                room = "次卧";
            }
            if (command.Contains("灯"))
            {
                if (command.Contains("开"))
                {
                    _mainForm.UpdateDeviceStatus(room, "灯", "开");
                    response = room +"灯已打开";
                }
                else if (command.Contains("关"))
                {
                    _mainForm.UpdateDeviceStatus(room, "灯", "关");
                    response = room + "灯已关闭";
                }
            }
            else if (command.Contains("空调"))
            {
                if (command.Contains("开"))
                {
                    _mainForm.UpdateDeviceStatus(room, "空调", "开");
                    response = room + "空调已打开";
                }
                else if (command.Contains("关"))
                {
                    _mainForm.UpdateDeviceStatus(room, "空调", "关");
                    response = room + "空调已关闭";
                }
            }
            if (response == "")
            {
                response = _chatGPTHelper.GetChatGPTResponse("你现在是个智能音箱，简短回答问题，如果你没法理解，就回答我没听清，能再说一遍吗，用户说:" + command);
            }
            return response;
        }
    }
}
