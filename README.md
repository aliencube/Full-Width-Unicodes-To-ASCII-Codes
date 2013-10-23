# Full-Width Unicodes to ASCII Codes #

**Full-Width Unicodes to ASCII Codes (FWU2AC)** provides full-width Unicode characters to corresponding ASCII characters or vice versa.

**Full-Width Unicodes to ASCII Codes (FWU2AC)**는 영문 전각 문자 및 특수 문자를 아스키 문자로, 또는 그 반대로 변환시켜주는 라이브러리입니다.



# How It Works #

English characters and special characters used in Chinese, Japanese or Korean are sometimes found as full-width. In order for text processing, these full-width characters should be converted into ASCII characters, or vice versa for publishing. The Unicode range for full-width characters is `FF01-FF5E` as well as `3000` for the space character. Their corresponding ASCII code range is `0020-007E`. **FWU2AC** currently covers the following ranges:

* space character "&nbsp;"
* `!"#$%&'()*+,-./`
* `0` to `9`
* `:;<=>?@`
* `A` to `Z`
* `[\]^_```
* `a` to `z`, and
* `{|}~`

중문, 일문, 한글에서 영문 글자와 특수 문자들은 종종 전각 문자로 쓰이곤 합니다. 텍스트 처리를 위해서 이러한 전각 문자들은 아스키 문자열로 변환 시키거나 출판시에는 그 반대의 변환을 거쳐야 합니다. 전각 문자에 관련한 유니코드 문자열들의 범위는 `FF01-FF5E`과 공백 문자인 `3000`입니다. 이에 대응하는 아스키 코드 문자열의 범위는 `0020-007E`입니다. **FWU2AC**는 현재 아래 문자열들을 지원하고 있습니다.

* 공백 문자 "&nbsp;"
* `!"#$%&'()*+,-./`
* `0` to `9`
* `:;<=>?@`
* `A` to `Z`
* `[\]^_```
* `a` to `z`, and
* `{|}~`


# License #

**FWU2AC** is released under [MIT License](http://opensource.org/licenses/MIT).

> The MIT License (MIT)
> 
> Copyright (c) 2013 [aliencube.org](http://aliencube.org)
> 
> Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
> furnished to do so, subject to the following conditions:
> 
> The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
> 
> THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


**FWU2AC**는 [MIT 라이센스](http://opensource.org/licenses/MIT)를 따릅니다.

> MIT 라이센스
> Copyright (c) 2013 [aliencube.org](http://aliencube.org)
>  
> 이 소프트웨어의 복제본과 관련된 문서화 파일("소프트웨어")을 획득하는 사람은 누구라도 소프트웨어를 별다른 제한 없이 무상으로 사용할 수 있는 권한을 부여 받는다. 여기에는 소프트웨어의 복제본을 무제한으로 사용, 복제, 수정, 병합, 공표, 배포, 서브라이선스 설정 및 판매할 수 있는 권리와 이상의 행위를 소프트웨어를 제공받은 다른 수취인들에게 허용할 수 있는 권리가 포함되며, 다음과 같은 조건을 충족시키는 것을 전제로 한다.
>  
> 위와 같은 저작권 안내 문구와 본 허용 문구가 소프트웨어의 모든 복제본 및 중요 부분에 포함되어야 한다.
>  
> **이 소프트웨어는 상품성, 특정 목적 적합성, 그리고 비침해에 대한 보증을 포함한 어떠한 형태의 보증도 명시적이나 묵시적으로 설정되지 않은 “있는 그대로의” 상태로 제공된다. 소프트웨어를 개발한 프로그래머나 저작권자는 어떠한 경우에도 소프트웨어나 소프트웨어의 사용 등의 행위와 관련하여 일어나는 어떤 요구사항이나 손해 및 기타 책임에 대해 계약상, 불법행위 또는 기타 이유로 인한 책임을 지지 않는다.**
