# VSReactComponentTemplates
Adds easy to create and setup Typescript React Templates for Visual Studio. 
Offers automatic scss and index.ts file creation with optional creation of props type.

## Instalation
1) Download latest ```.vsix``` from https://github.com/51MARGL/VSReactComponentTemplates/releases
2) Install extension for VS.

## How to use
 1) Add New Item  
 ![image](https://user-images.githubusercontent.com/28912735/184450255-45b6f0eb-face-4231-af5d-64050190d0dd.png)
 2) Select React Component Template. Enter Component Name and press Add  
 ![image](https://user-images.githubusercontent.com/28912735/184450521-2ad9f9e4-78b0-42af-a5cf-dd35e722816b.png)
 3) Select desired settings and press Finish  
 ![image](https://user-images.githubusercontent.com/28912735/184450602-d6e3de66-fb2b-48a3-a7c3-7fb3a0b2a7b4.png)
 4) New component should be created.  
 ![image](https://user-images.githubusercontent.com/28912735/184450759-5ae9f460-31b2-44d4-acca-b4c8ec781405.png)  
 ### SimpleReactComponent.tsx:
```typescript
import React from 'react';

import './SimpleReactComponent.scss';

export type SimpleReactComponentProps = {

}

const SimpleReactComponent: React.FC<SimpleReactComponentProps> = () => {
    return (
        <div className="simple-react-component"></div>
    );
}

SimpleReactComponent.displayName = 'SimpleReactComponent';

export default React.memo(SimpleReactComponent);
```
### SimpleReactComponent.scss:
```scss
$component: .simple-react-component;

#{$component} {
}
```
### index.ts:
```typescript
export * from './SimpleReactComponent';
export { default } from './SimpleReactComponent';
```