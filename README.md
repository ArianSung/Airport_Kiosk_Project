# Airport Kiosk Project ✈️

공항 자동 체크인 키오스크 시스템

A self-service airport check-in kiosk system

## 📋 프로젝트 소개 (Project Overview)

이 프로젝트는 공항에서 사용되는 자동 체크인 키오스크를 구현한 Windows Forms 애플리케이션입니다. 승객이 스스로 체크인, 좌석 선택, 탑승권 발권까지 수행할 수 있는 시스템입니다.

This is a Windows Forms application that implements a self-service check-in kiosk for airports. Passengers can perform check-in, seat selection, and boarding pass issuance on their own.

## 🚀 주요 기능 (Key Features)

- **예약 조회** - 예약 정보 확인 및 검색
- **항공사 선택** - 다양한 항공사 중 선택
- **좌석 선택** - 좌석 배치도를 통한 선호 좌석 선택
- **위험물 안내** - 탑승 전 위험물 안내 확인
- **체크인 완료** - 탑승권 발급 및 체크인 완료
- **다국어 지원** - 다국어 인터페이스 제공

---

- **Booking Lookup** - Check and search booking information
- **Airline Selection** - Choose from various airlines
- **Seat Selection** - Select preferred seat through seat map
- **Dangerous Goods Notice** - Review prohibited items before boarding
- **Check-in Completion** - Issue boarding pass and complete check-in
- **Multi-language Support** - Multi-language interface

## 🛠️ 기술 스택 (Tech Stack)

- **Language**: C#
- **Framework**: .NET Framework / Windows Forms
- **IDE**: Visual Studio
- **Architecture**: Form-based Desktop Application

## 📁 프로젝트 구조 (Project Structure)

```
Airport_Kiosk_Project/
├── Program.cs                          # 애플리케이션 진입점
├── MainForm.cs                         # 메인 폼
├── MainMenuControls.cs                 # 메인 메뉴 컨트롤
├── CheckInMenu.cs                      # 체크인 메뉴
├── Page_Booking_Check.cs               # 예약 확인 페이지
├── Page_Select_AirLines.cs             # 항공사 선택 페이지
├── Page_Select_Seat.cs                 # 좌석 선택 페이지
├── Page_Show_Booking.cs                # 예약 정보 표시 페이지
├── Page_Ticketing_End.cs               # 발권 완료 페이지
├── Page_No_Data.cs                     # 데이터 없음 페이지
├── DangerousGoodsNoticePage.cs         # 위험물 안내 페이지
├── BookingDatabase.cs                  # 예약 데이터베이스
├── BookingInfo.cs                      # 예약 정보 클래스
├── SeatDatabase.cs                     # 좌석 데이터베이스
├── LanguageManager.cs                  # 언어 관리자
└── Resources/                          # 리소스 파일
```



## 🎯 사용 흐름 (User Flow)

1. **언어 선택** → 원하는 언어 선택
2. **예약 조회** → 예약 번호 또는 여권 정보 입력
3. **항공사 선택** → 탑승할 항공사 선택
4. **좌석 선택** → 좌석 배치도에서 좌석 선택
5. **위험물 안내 확인** → 반입 금지 물품 확인
6. **체크인 완료** → 탑승권 발급


- Thanks to everyone who contributed to this project

---

⭐ 이 프로젝트가 도움이 되었다면 Star를 눌러주세요!

⭐ If you find this project helpful, please give it a star!
