import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ThistorysComponent } from './thistorys.component';

describe('ThistorysComponent', () => {
  let component: ThistorysComponent;
  let fixture: ComponentFixture<ThistorysComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ThistorysComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ThistorysComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
