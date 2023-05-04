import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TreliefsComponent } from './treliefs.component';

describe('TreliefsComponent', () => {
  let component: TreliefsComponent;
  let fixture: ComponentFixture<TreliefsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TreliefsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TreliefsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
