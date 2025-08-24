using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Kiosk_Project
{
    public static class LanguageManager
    {
        // 지원할 언어 목록을 enum으로 정의
        public enum Language { Korean, English, Chinese, Japanese }

        // 현재 설정된 언어 (기본값: 한국어)
        public static Language CurrentLanguage { get; private set; } = Language.Korean;

        // 언어가 변경되었을 때 보낼 신호(Event)
        public static event EventHandler LanguageChanged;

        // 모든 텍스트를 저장할 딕셔너리
        private static Dictionary<string, Dictionary<Language, string>> texts;

        static LanguageManager()
        {
            texts = new Dictionary<string, Dictionary<Language, string>>
            {
                // 여기에 프로그램에 필요한 모든 텍스트를 추가합니다.
                // 항공사 선택 페이지 제목
                { "Title_AirlineSelect", new Dictionary<Language, string>
                    {
                        { Language.Korean, "항공사를 선택해 주세요" },
                        { Language.English, "Please select your airline" },
                        { Language.Chinese, "请选择航空公司" },
                        { Language.Japanese, "航空会社を選択してください" }
                    }
                },
                // 체크인 페이지
                { "CheckIn_Btn", new Dictionary<Language, string>
                    {
                        {Language.Korean, " 체크인" },
                        {Language.English, "Check In" },
                        {Language.Chinese, "报到" },
                        {Language.Japanese, "チェックイン" }
                    }
                },
                // 위험물품
                {"Next_Btn", new Dictionary<Language, string>
                    {
                        {Language.Korean, "다음"},
                        {Language.English, "Next"},
                        {Language.Chinese, "下一个" },
                        {Language.Japanese, "次" }
                    }
                },
                {"Last_Btn", new Dictionary<Language, string>
                    {
                        {Language.Korean, "이전" },
                        {Language.English,"Previous" },
                        {Language.Chinese, "回去" },
                        {Language.Japanese,"戻る" }
                    }
                },
                {"Exit_Btn", new Dictionary<Language, string>
                    {
                        {Language.Korean, "나가기" },
                        {Language.English,"Exit" },
                        {Language.Chinese, "出去" },
                        {Language.Japanese,"出る" }
                    }
                },
                {"Agree_Btn", new Dictionary<Language, string>
                    {
                        {Language.Korean, "동의" },
                        {Language.English,"Agree" },
                        {Language.Chinese, "协议" },
                        {Language.Japanese,"同意" }
                    }
                },

                // 예약번호 입력
                {"Next_Btn1", new Dictionary<Language, string>
                    {
                        {Language.Korean, "다음"},
                        {Language.English, "Next"},
                        {Language.Chinese, "下一个" },
                        {Language.Japanese, "次" }
                    }
                },
                {"Exit_Btn1", new Dictionary<Language, string>
                    {
                        {Language.Korean, "나가기" },
                        {Language.English,"Exit" },
                        {Language.Chinese, "出去" },
                        {Language.Japanese,"出る" }
                    }
                },
                {"Book_Num", new Dictionary<Language, string>
                    {
                        {Language.Korean, "예약번호" },
                        {Language.English,"Reservation Number" },
                        {Language.Chinese, "预约号码" },
                        {Language.Japanese,"予約番号" }
                    }
                },

                // NoData Page
                {"Confirm_Btn", new Dictionary<Language, string>
                    {
                        {Language.Korean, "확인" },
                        {Language.English,"Check" },
                        {Language.Chinese, "查看" },
                        {Language.Japanese,"確認" }
                    }
                },
                {"Lable_Warn", new Dictionary<Language, string>
                    {
                        {Language.Korean, "입력하신 정보와 일치하는\r\n      예약이 없습니다." },
                        {Language.English,"There are no reservations matching\r\n   the information you entered." },
                        {Language.Chinese, "没有与您输入的信\r\n   息相符的预订。" },
                        {Language.Japanese,"入力した情報と一致する\r\n    予約はありません。" }
                    }
                },

                // 예약정보 표시페이지
                {"Lb_Book_Num", new Dictionary<Language, string>
                    {
                        {Language.Korean, "예약번호" },
                        {Language.English,"number" },
                        {Language.Chinese, "预约号码" },
                        {Language.Japanese,"予約番号" }
                    }
                },
                {"Lb_Name", new Dictionary<Language, string>
                    {
                        {Language.Korean, "대표자 이름" },
                        {Language.English,"name" },
                        {Language.Chinese, "代表姓名" },
                        {Language.Japanese,"代表者名" }
                    }
                },
                {"Lb_People", new Dictionary<Language, string>
                    {
                        {Language.Korean, "승객정보" },
                        {Language.English,"Passenger" },
                        {Language.Chinese, "旅客信息" },
                        {Language.Japanese,"乗客情報" }
                    }
                },
                {"Lb_Data_Adult", new Dictionary<Language, string>
                    {
                        {Language.Korean, "어른 : " },
                        {Language.English, "Adult : " },
                        {Language.Chinese, "成人 : " },
                        {Language.Japanese,"大人 : " }
                    }
                },
                {"Lb_Data_Child", new Dictionary<Language, string>
                    {
                        {Language.Korean, "아이 : " },
                        {Language.English,"Child : " },
                        {Language.Chinese, "孩子 : " },
                        {Language.Japanese,"子供 : " }
                    }
                },
                
                
                
                // ... 다른 모든 텍스트들도 이런 형식으로 추가 ...
            };
        }
        // 언어를 변경하는 메서드
        public static void SetLanguage(Language language)
        {
            CurrentLanguage = language;
            // 언어가 변경되었다고 신호를 보냄
            LanguageChanged?.Invoke(null, EventArgs.Empty);
        }

        // 키(Key)를 주면 현재 언어에 맞는 텍스트를 반환하는 메서드
        public static string GetText(string key)
        {
            if (texts.ContainsKey(key) && texts[key].ContainsKey(CurrentLanguage))
            {
                return texts[key][CurrentLanguage];
            }
            // 만약 해당 텍스트가 없으면 키를 그대로 반환 (오류 방지)
            return key;
        }

    }
}
